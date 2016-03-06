var assert = require('assert'),
    dnvmList = require('..');

describe('dnvm-list', function() {
  it('should say hello', function(done) {
    assert.equal(dnvmList(), 'Hello, world');
    done();
  });
});

