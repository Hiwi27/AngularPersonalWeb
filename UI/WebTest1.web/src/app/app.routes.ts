import { Routes } from '@angular/router';
import { RegisterContactComponent } from './register-contact/register-contact.component';
import { ContactsTabComponent } from './contacts-tab/contacts-tab.component';

export const routes: Routes = [
    {
        path: '',
        redirectTo: 'RegisterContact',
        pathMatch: 'full'
    },
    {
        path:'RegisterContact',
        component:RegisterContactComponent
    },
    {
        path:'ContactsTab',
        component:ContactsTabComponent
    }
];
