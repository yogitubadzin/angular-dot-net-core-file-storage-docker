import { Component, OnInit } from '@angular/core';
import { FileUploadService } from '../file-upload.service';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-upload-file',
  templateUrl: './upload-file.component.html',
  styleUrls: ['./upload-file.component.css']
})
export class UploadFileComponent implements OnInit {
  fileToUpload: File = null;
  isSuccess = false;
  isError = false;
  isFileRequired = false;
  errorMessage = '';
  uploadFileForm = new FormGroup({
    uploadFileButton: new FormControl(),
    descriptionText: new FormControl()
  });

  constructor(private fileUploadService: FileUploadService) { }

  ngOnInit() { }

  handleFileInput(files: FileList) {
    this.fileToUpload = files.item(0);
    this.isError = false;
    this.isSuccess = false;
    this.isFileRequired = false;
  }

  onSubmit() {
    this.errorMessage = '';
    this.isError = false;
    this.isSuccess = false;
    this.isFileRequired = false;

    if (!this.fileToUpload) {
      this.isFileRequired = true;
    }

    this.fileUploadService.postFile(this.fileToUpload, this.uploadFileForm.get('descriptionText').value)
      .subscribe(data => {
        this.isError = false;
        this.isSuccess = true;
        this.isFileRequired = false;
      }, error => {
        this.isError = true;
        this.isSuccess = false;
        this.isFileRequired = false;
        this.errorMessage = error.error.errors.Description[1];
        console.log(error);
      });
  }
}
