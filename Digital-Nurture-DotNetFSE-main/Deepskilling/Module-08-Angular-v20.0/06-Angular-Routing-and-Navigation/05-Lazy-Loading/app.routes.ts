import { Routes } from '@angular/router';

import { HomeComponent } from './home';
import { AboutComponent } from './about';
import { ContactComponent } from './contact';

export const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'about', component: AboutComponent },
  { path: 'contact', component: ContactComponent }
];
