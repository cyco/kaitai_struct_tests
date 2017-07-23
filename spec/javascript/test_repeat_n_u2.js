var assert = require('assert');
var testHelper = require('testHelper');

testHelper('RepeatNU2', 'src/repeat_n_u2.bin', function(r) {
    assert.equal(r.entries.length, 3);
    assert.equal(r.entries[0], 0x002A)
    assert.equal(r.entries[1], 0x0017)
    assert.equal(r.entries[2], 0xffff)

    assert.ok(r.entries instanceof Uint16Array);
});
