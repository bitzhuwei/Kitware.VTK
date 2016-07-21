using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXMLPolyDataReader : vtkXMLUnstructuredDataReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPolyDataReader";

		public new static readonly string MRClassNameKey;

		static vtkXMLPolyDataReader()
		{
			vtkXMLPolyDataReader.MRClassNameKey = "class vtkXMLPolyDataReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPolyDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPolyDataReader"));
		}

		public vtkXMLPolyDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPolyDataReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLPolyDataReader New()
		{
			vtkXMLPolyDataReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPolyDataReader.vtkXMLPolyDataReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPolyDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXMLPolyDataReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXMLPolyDataReader.vtkXMLPolyDataReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern long vtkXMLPolyDataReader_GetNumberOfLines_01(HandleRef pThis);

		public virtual long GetNumberOfLines()
		{
			return vtkXMLPolyDataReader.vtkXMLPolyDataReader_GetNumberOfLines_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern long vtkXMLPolyDataReader_GetNumberOfPolys_02(HandleRef pThis);

		public virtual long GetNumberOfPolys()
		{
			return vtkXMLPolyDataReader.vtkXMLPolyDataReader_GetNumberOfPolys_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern long vtkXMLPolyDataReader_GetNumberOfStrips_03(HandleRef pThis);

		public virtual long GetNumberOfStrips()
		{
			return vtkXMLPolyDataReader.vtkXMLPolyDataReader_GetNumberOfStrips_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern long vtkXMLPolyDataReader_GetNumberOfVerts_04(HandleRef pThis);

		public virtual long GetNumberOfVerts()
		{
			return vtkXMLPolyDataReader.vtkXMLPolyDataReader_GetNumberOfVerts_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPolyDataReader_GetOutput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetOutput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPolyDataReader.vtkXMLPolyDataReader_GetOutput_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkXMLPolyDataReader_GetOutput_06(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetOutput(int idx)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPolyDataReader.vtkXMLPolyDataReader_GetOutput_06(base.GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkXMLPolyDataReader_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLPolyDataReader.vtkXMLPolyDataReader_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLPolyDataReader_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLPolyDataReader.vtkXMLPolyDataReader_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPolyDataReader_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLPolyDataReader NewInstance()
		{
			vtkXMLPolyDataReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPolyDataReader.vtkXMLPolyDataReader_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPolyDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPolyDataReader_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLPolyDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPolyDataReader vtkXMLPolyDataReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPolyDataReader.vtkXMLPolyDataReader_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPolyDataReader = (vtkXMLPolyDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPolyDataReader.Register(null);
				}
			}
			return vtkXMLPolyDataReader;
		}
	}
}
