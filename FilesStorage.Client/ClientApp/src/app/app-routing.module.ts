import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";

const routes: Routes = [
    {
      path: "",
      redirectTo: "read",
      pathMatch: "full",
    },
    {
      path: "read",
      loadChildren: () => import("./file-storage-read/file-storage-read.module").then((m) => m.FileStorageReadModule),
    },
    {
      path: "write",
      loadChildren: () => import("./file-storage-write/file-storage-write.module").then((m) => m.FileStorageWriteModule),
    }
  ];
  
  @NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule],
  })
  export class AppRoutingModule {}