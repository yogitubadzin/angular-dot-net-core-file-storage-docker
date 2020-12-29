import { Component, OnInit } from '@angular/core';
import { FileUploadService } from '../file-upload.service';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-upload-file',
  templateUrl: './upload-file.component.html',
  styleUrls: ['./upload-file.component.css']
})
export class UploadFileComponent implements OnInit {
  fileToUpload: File = null;
  isSuccess = false;
  constructor(private fileUploadService: FileUploadService) { }

  ngOnInit() {
  }

  handleFileInput(files: FileList) {
    this.fileToUpload = files.item(0);
  }

  onSubmit() {
    this.fileUploadService.postFile(this.fileToUpload).subscribe(data => {
      this.isSuccess = true;
      }, error => {
        console.log(error);
      });
  }
}
