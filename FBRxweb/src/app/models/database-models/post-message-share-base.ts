import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class PostMessageShareBase {

//#region postMessageShareId Prop
        @prop()
        postMessageShareId : number;
//#endregion postMessageShareId Prop


//#region postMessageId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        postMessageId : number;
//#endregion postMessageId Prop


//#region userId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        userId : number;
//#endregion userId Prop





}