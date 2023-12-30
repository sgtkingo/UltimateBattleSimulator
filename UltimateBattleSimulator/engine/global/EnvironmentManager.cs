using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateBattleSimulator.engine.global
{
    internal static class EnvironmentManager
    {
        public static bool UseEnvironmentConfig { get; set; } = true;
        public static EnvironmentConfig EnvironmentConfig { get; set; } = new EnvironmentConfig();

        public static EnvironmentConfig GetUsedEnvironment 
        {
            get 
            {
                return UseEnvironmentConfig ? EnvironmentConfig : EnvironmentConfig.Empty;
            }
        }

        public static Dictionary<int, string> TerainStatus { get; private set; } = new Dictionary<int, string>()
        {
            { 0, "Flat Plains: Vast, open lands with minimal elevation changes, ideal for agriculture and settlement." },
            { 1, "Rolling Hills: Gently undulating terrain, more varied than plains, often used for grazing or vineyards." },
            { 2, "Lowlands: Slightly elevated areas, often near rivers or lakes, with fertile soil and mixed vegetation." },
            { 3, "Plateaus: Elevated flat areas, higher than plains, can have steep cliffs on one or more sides." },
            { 4, "River Valleys: Areas around rivers, characterized by fertile soil, with occasional hills or bluffs." },
            { 5, "Foothills: Transition zones at the base of mountains, with increasing elevation and ruggedness." },
            { 6, "Highland: Elevated terrain, often rugged and less densely populated, with a mix of hills and small mountains." },
            { 7, "Mountain Basins: Enclosed areas within mountain ranges, often with a central valley or lake." },
            { 8, "Rugged Mountains: Steep, rocky terrain, with sharp peaks and deep valleys, challenging for navigation." },
            { 9, "High Mountains: Very high elevations, with snow-capped peaks and limited vegetation, extreme conditions." },
            { 10, "Alpine Terrain: The highest and most rugged mountains, often above the tree line, with glaciers and limited accessibility." }
        };

        public static Dictionary<int, string> RiversAndLakesStatus { get; private set; } = new Dictionary<int, string>()
        {
            { 0, "Barren Terrain: Completely devoid of lakes and rivers, extremely arid." },
            { 1, "Sparse Stream: A single, small stream with no significant lakes, indicating a dry area." },
            { 2, "Small Pond with Minor Stream: A tiny pond accompanied by a minor stream, minimal water presence." },
            { 3, "Glacial Lake with Brook: A small glacial lake alongside a brook, characteristic of cold, mountainous regions." },
            { 4, "Crater Lake with Creek: A medium-sized crater lake with a creek, often in volcanic terrains." },
            { 5, "Oxbow Lake with Small River: An oxbow lake paired with a small river, typical of flat landscapes." },
            { 6, "Tarn with Medium River: A mountain lake accompanied by a medium-sized river, indicative of rugged terrain." },
            { 7, "Artificial Lake with Large River: A sizable man-made lake alongside a large river, common in developed areas." },
            { 8, "Great Lake with Braided River: A very large natural lake with a complex, braided river system." },
            { 9, "Multiple Lakes with Meandering River: Several medium-sized lakes with a winding river, indicating a water-rich landscape." },
            { 10, "Vast Water Network: Numerous large lakes interconnected with extensive river systems, denoting an extremely water-abundant environment." }
        };

        public static Dictionary<int, string> SwampsStatus { get; private set; } = new Dictionary<int, string>()
        {
            { 0, "No Swamp: Completely devoid of swamps, dry or urban terrain." },
            { 1, "Sparse Wetland: Isolated patches of wetland, indicating minimal swamp presence." },
            { 2, "Small Marsh: A small marsh area, possibly seasonal, with limited wetland vegetation." },
            { 3, "Bog: Acidic wetland with peat deposits, sphagnum moss, and heath vegetation." },
            { 4, "Fen: Alkaline wetland with waterlogged soils and diverse plant life." },
            { 5, "Wet Meadow: A grassy wetland area, often seasonally flooded with shallow water." },
            { 6, "Swamp Forest: Forested wetland with trees like cypress or mangroves, often flooded." },
            { 7, "Extensive Marshland: A large area of marshes, indicating significant wetland presence." },
            { 8, "Flooded Grassland: Vast, seasonally flooded grasslands, with semi-aquatic vegetation." },
            { 9, "Mangrove Swamp: Dense mangrove forests, typically found along coasts in tropical regions." },
            { 10, "Vast Wetland Complex: An expansive mix of marshes, bogs, fens, and swamp forests, indicating a highly water-saturated landscape." }
        };

        public static Dictionary<int, string> RainStatus { get; private set; } = new Dictionary<int, string>()
        {
            { 0, "Clear: No rain, clear skies." },
            { 1, "Light Drizzle: Very light rain, barely noticeable, might not wet the ground." },
            { 2, "Occasional Rain: Intermittent light rain, short-lived showers." },
            { 3, "Steady Light Rain: Continuous light rain, consistent but not heavy." },
            { 4, "Moderate Rain: Steady rain, noticeable and may last for a few hours." },
            { 5, "Heavy Showers: Intense rain over a short period, leading to quick accumulation of water." },
            { 6, "Persistent Moderate Rain: Continuous and steady moderate rain, lasting several hours." },
            { 7, "Heavy Rain: Prolonged and intense rain, can cause flooding in low-lying areas." },
            { 8, "Torrential Rain: Extremely heavy rain, leading to significant water accumulation and flooding risks." },
            { 9, "Tropical Downpour: Intense rain typical of tropical climates, often accompanied by thunderstorms." },
            { 10, "Monsoon Rains: Extremely heavy, relentless rain characteristic of monsoon seasons, leading to widespread flooding." }
        };

        public static Dictionary<int, string> WindStatus { get; private set; } = new Dictionary<int, string>()
        {
            { 0, "Calm: No wind, still air." },
            { 1, "Light Air: Barely noticeable wind, smoke drifts but leaves are still." },
            { 2, "Light Breeze: Leaves and small twigs in constant motion, wind felt on face." },
            { 3, "Gentle Breeze: Leaves and small branches move, light flags extended." },
            { 4, "Moderate Breeze: Raises dust and loose paper, small branches begin to sway." },
            { 5, "Fresh Breeze: Small trees in leaf begin to sway, crested wavelets form on lakes and ponds." },
            { 6, "Strong Breeze: Large branches in motion, umbrellas used with difficulty." },
            { 7, "Near Gale: Whole trees in motion, inconvenient to walk against the wind." },
            { 8, "Gale: Twigs break off trees, walking against the wind is very difficult." },
            { 9, "Strong Gale: Slight structural damage occurs, shingles blown off roofs." },
            { 10, "Storm: Trees uprooted, considerable structural damage, very rare occurrences." }
        };

        public static Dictionary<int, string> FogStatus { get; private set; } = new Dictionary<int, string>()
        {
            { 0, "Clear: No fog, excellent visibility." },
            { 1, "Slight Haze: Very light mist, visibility slightly reduced." },
            { 2, "Light Fog: Mild fog reducing visibility, objects at a distance are slightly blurred." },
            { 3, "Partial Fog: Moderate fog, visibility reduced, nearby objects are clear, distant ones are not." },
            { 4, "Moderate Fog: Consistent fog, visibility significantly reduced, difficult to see distant objects." },
            { 5, "Dense Fog: Heavy fog, very limited visibility, only very nearby objects are visible." },
            { 6, "Thick Fog: Extremely dense fog, visibility very limited, difficult to navigate." },
            { 7, "Pea Soup Fog: Exceptionally thick fog, visibility almost zero, akin to dense smoke." },
            { 8, "Freezing Fog: Fog combined with temperatures below freezing, creates icy conditions." },
            { 9, "Radiation Fog: Intense ground fog, typically forms at night and dissipates by morning." },
            { 10, "Advection Fog: Persistent fog, often coastal, caused by warm, moist air over cooler surfaces." }
        };

        public static Dictionary<int, string> SnowStatus { get; private set; } = new Dictionary<int, string>()
        {
            { 0, "No Snow: Clear, no snowfall." },
            { 1, "Light Flurries: Very light snowfall, no significant accumulation." },
            { 2, "Light Snow: Gentle snowfall, light accumulation, may not impact travel." },
            { 3, "Moderate Snow: Steady snowfall, moderate accumulation, can cause minor travel delays." },
            { 4, "Heavy Snow Showers: Intense snowfall over a short period, significant accumulation." },
            { 5, "Steady Heavy Snow: Continuous heavy snow, leading to rapid accumulation and travel difficulties." },
            { 6, "Snowstorm: Severe snowfall with strong winds, causing reduced visibility and potential hazards." },
            { 7, "Blizzard: Intense snowstorm with strong winds, extremely low visibility, and deep snow accumulation." },
            { 8, "Ice Pellets: Snow mixed with ice pellets, creating slippery surfaces and challenging conditions." },
            { 9, "Sleet: Combination of rain and snow, creates icy conditions and potential travel disruptions." },
            { 10, "Snow Squall: Short, intense bursts of snowfall, leading to sudden whiteout conditions and hazardous travel." }
        };

    }
}
