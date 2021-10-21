import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FeaturesFormComponent } from './components/features-form/features-form.component';

const routes: Routes = [
  { path: 'api/home/:id', component: FeaturesFormComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
