import unittest

from nested_same_name2 import NestedSameName2

class TestNestedSameName2(unittest.TestCase):
    def test_nested_same_name2(self):
        r = NestedSameName2.from_file("src/nested_same_name2.bin")

        self.assertEqual(r.version, 0x42)
        self.assertEqual(r.main_data.main_size, 2)
        self.assertEqual(r.main_data.foo.data1, b"\x11\x11\x11\x11")
        self.assertEqual(r.dummy.dummy_size, 3)
        self.assertEqual(r.dummy.foo.data2, b"\x22\x22\x22\x22\x22\x22")
