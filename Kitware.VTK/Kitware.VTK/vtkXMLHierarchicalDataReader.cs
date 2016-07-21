using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXMLHierarchicalDataReader : vtkXMLMultiGroupDataReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLHierarchicalDataReader";

		public new static readonly string MRClassNameKey;

		static vtkXMLHierarchicalDataReader()
		{
			vtkXMLHierarchicalDataReader.MRClassNameKey = "class vtkXMLHierarchicalDataReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLHierarchicalDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLHierarchicalDataReader"));
		}

		public vtkXMLHierarchicalDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLHierarchicalDataReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLHierarchicalDataReader New()
		{
			vtkXMLHierarchicalDataReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLHierarchicalDataReader.vtkXMLHierarchicalDataReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLHierarchicalDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXMLHierarchicalDataReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXMLHierarchicalDataReader.vtkXMLHierarchicalDataReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLHierarchicalDataReader_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLHierarchicalDataReader.vtkXMLHierarchicalDataReader_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLHierarchicalDataReader_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLHierarchicalDataReader.vtkXMLHierarchicalDataReader_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLHierarchicalDataReader_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLHierarchicalDataReader NewInstance()
		{
			vtkXMLHierarchicalDataReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLHierarchicalDataReader.vtkXMLHierarchicalDataReader_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLHierarchicalDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLHierarchicalDataReader_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLHierarchicalDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLHierarchicalDataReader vtkXMLHierarchicalDataReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLHierarchicalDataReader.vtkXMLHierarchicalDataReader_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLHierarchicalDataReader = (vtkXMLHierarchicalDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLHierarchicalDataReader.Register(null);
				}
			}
			return vtkXMLHierarchicalDataReader;
		}
	}
}
