import { Dictionary } from "./theme";

export class User {
    name: string;
    mail: string;
    phoneNumber: string;
    selectedTheme?: number;

    constructor(name: string, mail: string, phoneNumber: string) {
        this.name = name;
        this.mail = mail;
        this.phoneNumber = phoneNumber;
    }
}
