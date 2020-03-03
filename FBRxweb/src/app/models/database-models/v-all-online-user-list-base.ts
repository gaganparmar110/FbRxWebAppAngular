import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vAllOnlineUserListBase {

//#region firstname Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'firstname', keyColumn: false})
        firstname : string;
//#endregion firstname Prop

}