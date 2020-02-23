import { Component, OnInit } from '@angular/core';
import { Part } from '../part';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-partlist',
  templateUrl: './partlist.component.html',
  styleUrls: ['./partlist.component.css']
})
export class PartlistComponent implements OnInit {
  legoParts: Part[] = [];

  form: FormGroup;


  constructor(private fb: FormBuilder) { }


  ngOnInit() {
    
    this.form = this.fb.group({
      name: [this.legoParts .name, Validators.required],
      description: this.currentEvent.description,
      date: [this.currentEvent.date, Validators.required],
    });

  }

}
