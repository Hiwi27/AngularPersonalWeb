import { HttpClient } from '@angular/common/http';
import { Component, inject } from '@angular/core';
import { Observable } from 'rxjs';
import { Contact } from '../../Model/contact.model';
import { AsyncPipe } from '@angular/common';
import { ContactService } from '../contact.service';

@Component({
  selector: 'app-contacts-tab',
  imports: [AsyncPipe],
  templateUrl: './contacts-tab.component.html',
  styleUrl: './contacts-tab.component.css'
})
export class ContactsTabComponent {

 // Observable to store the list of contacts
 contacts$: Observable<Contact[]>;

 constructor(private contactService: ContactService) {
   // Assign the observable from the service to the contacts$
   this.contacts$ = this.contactService.getContacts();
 }
 
}
