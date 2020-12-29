import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FileStorageWriteRoutingModule } from './file-storage-write-routing.module';
import { UploadFileComponent } from './upload-file/upload-file.component';
import { FileUploadService } from './file-upload.service';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [UploadFileComponent],
  imports: [
    CommonModule,
    FileStorageWriteRoutingModule,
    ReactiveFormsModule,
    FormsModule
  ],
  providers: [FileUploadService]
})
export class FileStorageWriteModule { }
