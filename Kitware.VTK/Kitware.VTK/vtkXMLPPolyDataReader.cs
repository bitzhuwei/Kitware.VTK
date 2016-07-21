using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXMLPPolyDataReader : vtkXMLPUnstructuredDataReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPPolyDataReader";

		public new static readonly string MRClassNameKey;

		static vtkXMLPPolyDataReader()
		{
			vtkXMLPPolyDataReader.MRClassNameKey = "class vtkXMLPPolyDataReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPPolyDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPPolyDataReader"));
		}

		public vtkXMLPPolyDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPPolyDataReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLPPolyDataReader New()
		{
			vtkXMLPPolyDataReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPPolyDataReader.vtkXMLPPolyDataReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPPolyDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXMLPPolyDataReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXMLPPolyDataReader.vtkXMLPPolyDataReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPPolyDataReader_GetOutput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetOutput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPPolyDataReader.vtkXMLPPolyDataReader_GetOutput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPPolyDataReader_GetOutput_02(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetOutput(int idx)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPPolyDataReader.vtkXMLPPolyDataReader_GetOutput_02(base.GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLPPolyDataReader_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLPPolyDataReader.vtkXMLPPolyDataReader_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLPPolyDataReader_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLPPolyDataReader.vtkXMLPPolyDataReader_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPPolyDataReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLPPolyDataReader NewInstance()
		{
			vtkXMLPPolyDataReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPPolyDataReader.vtkXMLPPolyDataReader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPPolyDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPPolyDataReader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLPPolyDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPPolyDataReader vtkXMLPPolyDataReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPPolyDataReader.vtkXMLPPolyDataReader_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPPolyDataReader = (vtkXMLPPolyDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPPolyDataReader.Register(null);
				}
			}
			return vtkXMLPPolyDataReader;
		}
	}
}
