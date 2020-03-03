import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vOnlineUserListBase {

//#region firstName Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'firstName', keyColumn: false})
        firstName : string;
//#endregion firstName Prop


//#region userID Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'userID', keyColumn: true})
        userID : number;
//#endregion userID Prop

}