using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRTXMLPolyDataReader : vtkXMLPolyDataReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRTXMLPolyDataReader";

		public new static readonly string MRClassNameKey;

		static vtkRTXMLPolyDataReader()
		{
			vtkRTXMLPolyDataReader.MRClassNameKey = "class vtkRTXMLPolyDataReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRTXMLPolyDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRTXMLPolyDataReader"));
		}

		public vtkRTXMLPolyDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkRTXMLPolyDataReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRTXMLPolyDataReader New()
		{
			vtkRTXMLPolyDataReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRTXMLPolyDataReader.vtkRTXMLPolyDataReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRTXMLPolyDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRTXMLPolyDataReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRTXMLPolyDataReader.vtkRTXMLPolyDataReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkRTXMLPolyDataReader_GetDataLocation_01(HandleRef pThis);

		public virtual string GetDataLocation()
		{
			return Marshal.PtrToStringAnsi(vtkRTXMLPolyDataReader.vtkRTXMLPolyDataReader_GetDataLocation_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkRTXMLPolyDataReader_GetNextFileName_02(HandleRef pThis);

		public string GetNextFileName()
		{
			return Marshal.PtrToStringAnsi(vtkRTXMLPolyDataReader.vtkRTXMLPolyDataReader_GetNextFileName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkRTXMLPolyDataReader_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRTXMLPolyDataReader.vtkRTXMLPolyDataReader_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkRTXMLPolyDataReader_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRTXMLPolyDataReader.vtkRTXMLPolyDataReader_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkRTXMLPolyDataReader_NewDataAvailable_06(HandleRef pThis);

		public virtual int NewDataAvailable()
		{
			return vtkRTXMLPolyDataReader.vtkRTXMLPolyDataReader_NewDataAvailable_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkRTXMLPolyDataReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRTXMLPolyDataReader NewInstance()
		{
			vtkRTXMLPolyDataReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRTXMLPolyDataReader.vtkRTXMLPolyDataReader_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRTXMLPolyDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkRTXMLPolyDataReader_ResetReader_08(HandleRef pThis);

		public virtual void ResetReader()
		{
			vtkRTXMLPolyDataReader.vtkRTXMLPolyDataReader_ResetReader_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkRTXMLPolyDataReader_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRTXMLPolyDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkRTXMLPolyDataReader vtkRTXMLPolyDataReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRTXMLPolyDataReader.vtkRTXMLPolyDataReader_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRTXMLPolyDataReader = (vtkRTXMLPolyDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRTXMLPolyDataReader.Register(null);
				}
			}
			return vtkRTXMLPolyDataReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkRTXMLPolyDataReader_SetLocation_10(HandleRef pThis, string dataLocation);

		public void SetLocation(string dataLocation)
		{
			vtkRTXMLPolyDataReader.vtkRTXMLPolyDataReader_SetLocation_10(base.GetCppThis(), dataLocation);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkRTXMLPolyDataReader_UpdateToNextFile_11(HandleRef pThis);

		public virtual void UpdateToNextFile()
		{
			vtkRTXMLPolyDataReader.vtkRTXMLPolyDataReader_UpdateToNextFile_11(base.GetCppThis());
		}
	}
}
