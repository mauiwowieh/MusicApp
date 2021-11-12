export interface Song {
    id:           number;
    songName:     string;
    artistName:   string;
    songUrl:      string;
    songRating:   number;
    isFavourite:  boolean;
    songEntered:  Date;
    songEdited:   Date;
    songCategory: null;
}