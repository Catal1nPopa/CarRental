import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SidebarComponent } from './sidebar/sidebar.component';
import { FilterComponent } from './filter/filter.component';
import { CarBoxComponent } from './Car/car-box/car-box.component';

const routes: Routes = [
  { path: 'sidebar', component: SidebarComponent},
  { path: 'filter', component: FilterComponent},
  { path: 'car-box', component: CarBoxComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
