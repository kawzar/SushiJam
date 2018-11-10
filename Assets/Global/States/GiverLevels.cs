using UnityEditor;
using UnityEngine;

namespace Global.States
{
    public class GiverLevels
    {
        private static GiverLevels _instance;
        public static GiverLevels Instance => _instance = _instance ?? new GiverLevels();
        
        private Level[] _levels;

        private GiverLevels()
        {
            _levels = new Level[]
            {
                new CrabLevel(), new SalmonLevel(), new ShrimpLevel(), new TunaLevel(), 
            };
        }
        
        public Level GetRandom()
        {
            var rand = Random.Range(0, 4);
            Debug.Log(rand);
            Debug.Log(_levels[rand]);
            return _levels[rand];
        }
        
        

    }
}