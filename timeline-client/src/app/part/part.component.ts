import { Component, OnInit } from '@angular/core';
import { Part } from '../part';

@Component({
  selector: 'app-part',
  templateUrl: './part.component.html',
  styleUrls: ['./part.component.css']
})
export class PartComponent implements OnInit {
  part: Part = {
    partId: 66965,
    itemId: "87079pb636R",
    itemType: "P",
    itemName: "Tile 2 x 4 with Door with Gold Pull Ring Pattern Right Side Sticker - Set 71043",
    category: 39,
    categoryName: "Tile", 
    weight: 0.900,
    dimensionX: 2, 
    dimensionY: 4, 
    dimensionZ: null, 
    imageLink: "https://img.bricklink.com/ItemImage/PL/87079pb636R.png",
    iconLink: "https://img.bricklink.com/ItemImage/PT/88/87079pb636R.t1.png", // "https://img.bricklink.com/ItemImage/PT/1/87079pb636R.t1.png",
  };

  constructor() {
  }

  ngOnInit() {
  }

}
