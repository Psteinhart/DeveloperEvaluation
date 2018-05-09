import { Routes, RouterModule } from '@angular/router';

import { CalculateComponent } from './calculate/';
import {HomeComponent} from './home/index';

const appRoutes: Routes = [
     { path: '', component: HomeComponent},
    { path: 'calculate', component: CalculateComponent },
    // otherwise redirect to home
    { path: '**', redirectTo: '' }
];

export const routing = RouterModule.forRoot(appRoutes);
