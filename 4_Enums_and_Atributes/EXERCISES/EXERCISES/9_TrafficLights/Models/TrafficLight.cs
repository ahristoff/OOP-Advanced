using System;

namespace _9_TrafficLights.Models
{
    public class TrafficLight
    {
        private LightColor colorState;

        public TrafficLight(LightColor colorState)
        {
            this.colorState = colorState;
        }

        public LightColor ColorState => this.colorState;

        internal void UpdateState()
        {
            this.colorState++;

            var colorStatesCount = Enum.GetNames(typeof(LightColor)).Length;
            this.colorState = (LightColor)((int)this.colorState % colorStatesCount);
        }
    }
}