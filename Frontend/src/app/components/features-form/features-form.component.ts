import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { FeaturesFormService } from 'src/app/services/features-form-service';
import { FormFeaturesModel, Question } from './../../models/formFeaturesModel';

@Component({
  selector: 'app-features-form',
  templateUrl: './features-form.component.html',
  styleUrls: ['./features-form.component.css']
})
export class FeaturesFormComponent implements OnInit {
  id: string = "";
  private featuresFormService: FeaturesFormService;
  public featuresForm: FormFeaturesModel;
  public questions: Question[];

  constructor(private route: ActivatedRoute, featuresFormService: FeaturesFormService) {
    this.featuresFormService = featuresFormService;
   }

  ngOnInit(): void {
    this.route.params.subscribe(params => {
      this.id = params['id'];
    });

    this.featuresFormService.getForm(this.id).subscribe((featuresForm) => {
      this.featuresForm = featuresForm;
      this.questions = this.featuresForm.questions;
      console.log(this.featuresForm.questions);
    })
  }



}
