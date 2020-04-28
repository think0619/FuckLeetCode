///**
// * @param {number[][]} matrix
// */
var sumarray = []; 
    var NumMatrix = function (matrix) {
        sumarray = [];
        for (var i = 0; i < matrix.length; i++) {
            var rowArray = [];
            rowArray.push(0); 
            for (var j = 0; j < matrix[0].length; j++) {
                rowArray.push(matrix[i][j] + rowArray[j]);
            }
            sumarray.push(rowArray);
        }
    };

    ///** 
    // * @param {number} row1 
    // * @param {number} col1 
    // * @param {number} row2 
    // * @param {number} col2
    // * @return {number}
    // */
    NumMatrix.prototype.sumRegion = function (row1, col1, row2, col2) {
        let result = 0;
        for (var rowIndex = row1; rowIndex <= row2; rowIndex++) { 
            result += sumarray[rowIndex][col2 + 1] - sumarray[rowIndex][col1];
        }
        return result;
    };
///**
// * Your NumMatrix object will be instantiated and called as such:
// * var obj = new NumMatrix(matrix)
// * var param_1 = obj.sumRegion(row1,col1,row2,col2)
// */