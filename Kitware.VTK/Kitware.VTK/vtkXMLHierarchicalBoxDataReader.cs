using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXMLHierarchicalBoxDataReader : vtkXMLCompositeDataReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLHierarchicalBoxDataReader";

		public new static readonly string MRClassNameKey;

		static vtkXMLHierarchicalBoxDataReader()
		{
			vtkXMLHierarchicalBoxDataReader.MRClassNameKey = "class vtkXMLHierarchicalBoxDataReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLHierarchicalBoxDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLHierarchicalBoxDataReader"));
		}

		public vtkXMLHierarchicalBoxDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLHierarchicalBoxDataReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLHierarchicalBoxDataReader New()
		{
			vtkXMLHierarchicalBoxDataReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLHierarchicalBoxDataReader.vtkXMLHierarchicalBoxDataReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLHierarchicalBoxDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXMLHierarchicalBoxDataReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXMLHierarchicalBoxDataReader.vtkXMLHierarchicalBoxDataReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLHierarchicalBoxDataReader_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLHierarchicalBoxDataReader.vtkXMLHierarchicalBoxDataReader_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLHierarchicalBoxDataReader_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLHierarchicalBoxDataReader.vtkXMLHierarchicalBoxDataReader_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLHierarchicalBoxDataReader_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLHierarchicalBoxDataReader NewInstance()
		{
			vtkXMLHierarchicalBoxDataReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLHierarchicalBoxDataReader.vtkXMLHierarchicalBoxDataReader_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLHierarchicalBoxDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLHierarchicalBoxDataReader_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLHierarchicalBoxDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLHierarchicalBoxDataReader vtkXMLHierarchicalBoxDataReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLHierarchicalBoxDataReader.vtkXMLHierarchicalBoxDataReader_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLHierarchicalBoxDataReader = (vtkXMLHierarchicalBoxDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLHierarchicalBoxDataReader.Register(null);
				}
			}
			return vtkXMLHierarchicalBoxDataReader;
		}
	}
}
