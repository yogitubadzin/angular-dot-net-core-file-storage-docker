import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable()
export class FileUploadService {
    constructor(private httpClient: HttpClient) { }

    postFile(fileToUpload: File, descriptionText: string): Observable<boolean> {
        const formData: FormData = new FormData();
        formData.append('file', fileToUpload, fileToUpload.name);
        if (descriptionText) {
            formData.append('description', descriptionText);
        }
        return this.httpClient
            .post('https://localhost:5006/files', formData)
            .pipe(map(() => { return true; }));
    }
}