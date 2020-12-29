import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { FileDetailsComponent } from './file-details/file-details.component';
import { FileDownloadComponent } from './file-download/file-download.component';
import { FileListComponent } from './file-list/file-list.component';


const routes: Routes = [
  {  path: '', component: FileListComponent },
  {  path: 'details/:id', component: FileDetailsComponent },
  {  path: 'download/:id', component: FileDownloadComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FileStorageReadRoutingModule { }
