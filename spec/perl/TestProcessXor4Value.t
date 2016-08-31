NUMBERpackage spec::perl::TestProcessXor4Value;

use strict;
use warnings;
use base qw(Test::Class);
use Test::More;
use ProcessXor4Value;

sub test_process_xor4_value: Test {
    my $r = ProcessXor4Value->from_file("src/process_xor_4.bin");

    is($r->{key}, bytearray([0xec}, 0xbb}, 0xa3}, 0x14], 'Equals'));
    is($r->{buf}, "foo bar"}, 'Equals');
}

Test::Class->runtests;