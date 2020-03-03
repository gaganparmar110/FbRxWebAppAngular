import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vChatBase {

//#region media Prop
        @gridColumn({visible: true, columnIndex:0, allowSorting: true, headerKey: 'media', keyColumn: false})
        media : string;
//#endregion media Prop


//#region senderId Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'senderId', keyColumn: true})
        senderId : number;
//#endregion senderId Prop


//#region receiverId Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'receiverId', keyColumn: false})
        receiverId : number;
//#endregion receiverId Prop


//#region sendDateTime Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'sendDateTime', keyColumn: false})
        sendDateTime : any;
//#endregion sendDateTime Prop


//#region firstName Prop
        @gridColumn({visible: true, columnIndex:4, allowSorting: true, headerKey: 'firstName', keyColumn: false})
        firstName : string;
//#endregion firstName Prop


//#region userID Prop
        @gridColumn({visible: true, columnIndex:5, allowSorting: true, headerKey: 'userID', keyColumn: false})
        userID : number;
//#endregion userID Prop


//#region message Prop
        @gridColumn({visible: true, columnIndex:6, allowSorting: true, headerKey: 'message', keyColumn: false})
        message : string;
//#endregion message Prop


//#region expr1 Prop
        @gridColumn({visible: true, columnIndex:7, allowSorting: true, headerKey: 'expr1', keyColumn: false})
        expr1 : number;
//#endregion expr1 Prop


//#region expr2 Prop
        @gridColumn({visible: true, columnIndex:8, allowSorting: true, headerKey: 'expr2', keyColumn: false})
        expr2 : number;
//#endregion expr2 Prop


//#region expr3 Prop
        @gridColumn({visible: true, columnIndex:9, allowSorting: true, headerKey: 'expr3', keyColumn: false})
        expr3 : any;
//#endregion expr3 Prop

}