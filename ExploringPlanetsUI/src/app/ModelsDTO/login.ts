export class Login{
    public Email: string | undefined;
    public Password: string | undefined;

    constructor(init?: Partial<Login>){
        Object.assign(this, init);
    }
}