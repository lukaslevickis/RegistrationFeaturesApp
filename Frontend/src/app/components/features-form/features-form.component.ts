import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { FeaturesFormService } from 'src/app/services/features-form-service';
import { Question } from './../../models/formFeaturesModel';
import { Features, FeaturesModel } from './../../models/featuresModel';

@Component({
  selector: 'app-features-form',
  templateUrl: './features-form.component.html',
  styleUrls: ['./features-form.component.css']
})
export class FeaturesFormComponent implements OnInit {
  id: string = "";
  private featuresFormService: FeaturesFormService;
  public features: Features[] = [];
  public featuresModel: FeaturesModel;
  public questions: Question[];
  disabled: boolean = true;


  constructor(private route: ActivatedRoute, featuresFormService: FeaturesFormService) {
    this.featuresFormService = featuresFormService;
   }

  ngOnInit(): void {
    this.route.params.subscribe(params => {
      this.id = params['id'];
    });

    this.featuresFormService.getForm(this.id).subscribe((featuresForm) => {
      this.questions = featuresForm.questions;
    })
  }

  edit():void {
    this.disabled = false;
  }

  save():void {
    this.questions.forEach(element => {
      this.features.push({ QuestionId: element.id, AnswerId: element.answerId });
    });

    this.featuresFormService.updateForm(this.id, this.featuresModel = { Features: this.features })
                            .subscribe(() => { this.features = []; this.disabled = true });
  }
}
