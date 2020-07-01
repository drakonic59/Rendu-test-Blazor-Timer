using System;

namespace tp
{
    public class Timer
    {
        public int currentTimeH = 0, currentTimeM = 0, currentTimeS = 0;

        public Boolean isActive = false, isPause = false;

        public Timer(int h, int m, int s) {
            currentTimeH = h;
            currentTimeM = m;
            currentTimeS = s;
        }

        public void setHour(int h) {
            currentTimeH = h;
        }

        public void setMinutes(int m) {
            currentTimeM = m;
        }

        public void setSeconds(int s) {
            currentTimeS = s;
        }

        public int getHour() {
            return currentTimeH;
        }

        public int getMinutes() {
            return currentTimeM;
        }

        public int getSeconds() {
            return currentTimeS;
        }

        public void timetLoop() {
            long ms = 0;
            while (!isPause || isActive) {
                if (!isPause) {
                    ms++;
                    if (ms >= 1000) {
                        currentTimeS++;
                        ms = 0;
                    }
                    if (currentTimeS >= 60) {
                        currentTimeS = 0;
                        currentTimeM++;
                    }
                    if (currentTimeM >= 60) {
                        currentTimeM = 0;
                        currentTimeH++;
                    }
                    if (currentTimeH >= 24) {
                        currentTimeH = 0;
                        isActive = false;
                    }
                }
            }
        }
    }
}
