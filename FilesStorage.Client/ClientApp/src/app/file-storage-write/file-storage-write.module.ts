import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FileStorageWriteRoutingModule } from './file-storage-write-routing.module';
import { UploadFileComponent } from './upload-file/upload-file.component';


@NgModule({
  declarations: [UploadFileComponent],
  imports: [
    CommonModule,
    FileStorageWriteRoutingModule
  ]
})
export class FileStorageWriteModule { }
