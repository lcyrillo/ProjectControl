import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
    selector: 'app-profile',
    templateUrl: './profile.component.html',
})
export class ProfileComponent{
    public profiles: Profiles[];


}

interface Profiles {
    id: number;
    name: string;
    description: string;
    createdBy: number;
    deletedBy: number;
    inputDate: string;
    deleteDate: string;
}