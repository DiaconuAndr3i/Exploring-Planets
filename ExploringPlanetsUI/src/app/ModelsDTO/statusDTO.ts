export class Status{
    IdPlanet: string | undefined;
    Status: string | undefined;
    UserId: string | undefined;

    constructor(init?: Partial<Status>){
        Object.assign(this, init);
    }
}