using _9_TrafficLights.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9_TrafficLights
{
    public class Program
    {
        public static void Main()
        {
            var lightsInput = GetLightsInput();
            var changesCount = int.Parse(Console.ReadLine());

            var trafficLightsCollection = GetTrafficLights(lightsInput);

            RunTrafficLights(changesCount, trafficLightsCollection);
        }

        private static List<string> GetLightsInput()
        {
            return Console.ReadLine()
                   .Split()
                   .ToList();
        }

        private static List<TrafficLight> GetTrafficLights(List<string> lightsInput)
        {
            var trafficLightsCollection = new List<TrafficLight>();

            foreach (var lightSignal in lightsInput)
            {
                LightColor initialColorState = (LightColor)Enum.Parse(typeof(LightColor), lightSignal);
                trafficLightsCollection.Add(new TrafficLight(initialColorState));
            }

            return trafficLightsCollection;
        }

        private static void RunTrafficLights(int changesCount, List<TrafficLight> trafficLightsCollection)
        {
            for (int i = 0; i < changesCount; i++)
            {
                var sb = new StringBuilder();

                foreach (var trafficLight in trafficLightsCollection)
                {
                    trafficLight.UpdateState();

                    sb.Append(trafficLight.ColorState).Append(" ");
                }

                Console.WriteLine(sb.ToString().Trim());
            }
        }
    }
}
