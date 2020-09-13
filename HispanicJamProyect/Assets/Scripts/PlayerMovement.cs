using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField] Grid grid;
   // Start is called before the first frame update
   void Start()
   {

   }

   // Update is called once per frame
   void Update()
   {
      if (Input.GetKeyDown(KeyCode.D))
      {
         Vector3Int positionInGrid = grid.WorldToCell(transform.position);
         positionInGrid += new Vector3Int(1, 0, 0);
         transform.position = grid.CellToWorld(positionInGrid);
      }
   }
}
