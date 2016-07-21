using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXMLMultiGroupDataReader : vtkXMLMultiBlockDataReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLMultiGroupDataReader";

		public new static readonly string MRClassNameKey;

		static vtkXMLMultiGroupDataReader()
		{
			vtkXMLMultiGroupDataReader.MRClassNameKey = "class vtkXMLMultiGroupDataReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLMultiGroupDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLMultiGroupDataReader"));
		}

		public vtkXMLMultiGroupDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLMultiGroupDataReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLMultiGroupDataReader New()
		{
			vtkXMLMultiGroupDataReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLMultiGroupDataReader.vtkXMLMultiGroupDataReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLMultiGroupDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXMLMultiGroupDataReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXMLMultiGroupDataReader.vtkXMLMultiGroupDataReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLMultiGroupDataReader_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLMultiGroupDataReader.vtkXMLMultiGroupDataReader_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLMultiGroupDataReader_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLMultiGroupDataReader.vtkXMLMultiGroupDataReader_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLMultiGroupDataReader_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLMultiGroupDataReader NewInstance()
		{
			vtkXMLMultiGroupDataReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLMultiGroupDataReader.vtkXMLMultiGroupDataReader_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLMultiGroupDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLMultiGroupDataReader_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLMultiGroupDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLMultiGroupDataReader vtkXMLMultiGroupDataReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLMultiGroupDataReader.vtkXMLMultiGroupDataReader_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLMultiGroupDataReader = (vtkXMLMultiGroupDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLMultiGroupDataReader.Register(null);
				}
			}
			return vtkXMLMultiGroupDataReader;
		}
	}
}
