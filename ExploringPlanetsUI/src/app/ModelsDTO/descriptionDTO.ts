export class Description{
    IdPlanet: string | undefined;
    Description: string | undefined;
    UserId: string | undefined;

    constructor(init?: Partial<Description>){
        Object.assign(this, init);
    }
}