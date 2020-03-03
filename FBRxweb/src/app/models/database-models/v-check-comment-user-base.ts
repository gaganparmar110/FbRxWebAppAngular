import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vCheckCommentUserBase {

//#region userName Prop
        @gridColumn({visible: true, columnIndex:0, allowSorting: true, headerKey: 'userName', keyColumn: false})
        userName : string;
//#endregion userName Prop


//#region postId Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'postId', keyColumn: true})
        postId : number;
//#endregion postId Prop


//#region comment Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'comment', keyColumn: false})
        comment : string;
//#endregion comment Prop

}