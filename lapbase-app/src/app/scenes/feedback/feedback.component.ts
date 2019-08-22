import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-feedback",
  templateUrl: "./feedback.component.html",
  styleUrls: ["./feedback.component.scss"]
})
export class FeedbackComponent implements OnInit {
  show = true;

  constructor() {}

  ngOnInit() {}

  changeShow() {
    this.show = !this.show;
  }
}
