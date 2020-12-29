import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FileStorageReadRoutingModule } from './file-storage-read-routing.module';
import { FileDownloadComponent } from './file-download/file-download.component';
import { FileDetailsComponent } from './file-details/file-details.component';
import { FileListComponent } from './file-list/file-list.component';

@NgModule({
  declarations: [FileDownloadComponent, FileDetailsComponent, FileListComponent],
  imports: [
    CommonModule,
    FileStorageReadRoutingModule
  ]
})
export class FileStorageReadModule { }
