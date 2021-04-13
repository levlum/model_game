using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lev
{
    public class CreateLetters : MonoBehaviour
    {
        public string text;
        public GameObject letter_cube;

        // Start is called before the first frame update
        void Start()
        {
            Transform t = GetComponent<Transform>();
            Vector3 offset = t.position;
            Vector3 dir = t.right;
            for (int i=0; i < text.Length; i++)
            {
                var letter = text[i];
                if (letter != ' '){
                    var cube = GameObject.Instantiate(letter_cube, t);
                    string l = System.Char.IsNumber(letter)? "z"+letter : letter.ToString();
                    cube.GetComponent<Set_Letter_Up>().letter = (Letters)System.Enum.Parse(typeof(Letters), l, true);

                    var size = cube.GetComponent<Transform>().localScale.x;
                    Vector3 rand = new Vector3(Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f));
                    cube.GetComponent<Transform>().position = offset + dir * i * size * 1.2f + rand;
                }
            }
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
    
}
