using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXMLMultiBlockDataReader : vtkXMLCompositeDataReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLMultiBlockDataReader";

		public new static readonly string MRClassNameKey;

		static vtkXMLMultiBlockDataReader()
		{
			vtkXMLMultiBlockDataReader.MRClassNameKey = "class vtkXMLMultiBlockDataReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLMultiBlockDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLMultiBlockDataReader"));
		}

		public vtkXMLMultiBlockDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLMultiBlockDataReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLMultiBlockDataReader New()
		{
			vtkXMLMultiBlockDataReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLMultiBlockDataReader.vtkXMLMultiBlockDataReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLMultiBlockDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXMLMultiBlockDataReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXMLMultiBlockDataReader.vtkXMLMultiBlockDataReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLMultiBlockDataReader_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLMultiBlockDataReader.vtkXMLMultiBlockDataReader_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLMultiBlockDataReader_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLMultiBlockDataReader.vtkXMLMultiBlockDataReader_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLMultiBlockDataReader_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLMultiBlockDataReader NewInstance()
		{
			vtkXMLMultiBlockDataReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLMultiBlockDataReader.vtkXMLMultiBlockDataReader_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLMultiBlockDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLMultiBlockDataReader_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLMultiBlockDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLMultiBlockDataReader vtkXMLMultiBlockDataReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLMultiBlockDataReader.vtkXMLMultiBlockDataReader_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLMultiBlockDataReader = (vtkXMLMultiBlockDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLMultiBlockDataReader.Register(null);
				}
			}
			return vtkXMLMultiBlockDataReader;
		}
	}
}
