import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class ChatMediaBase {

//#region chatMediaId Prop
        @prop()
        chatMediaId : number;
//#endregion chatMediaId Prop


//#region media Prop
        @required()
        media : string;
//#endregion media Prop


//#region senderId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        senderId : number;
//#endregion senderId Prop


//#region receiverId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        receiverId : number;
//#endregion receiverId Prop


//#region sendDateTime Prop
        @required()
        sendDateTime : any;
//#endregion sendDateTime Prop





}