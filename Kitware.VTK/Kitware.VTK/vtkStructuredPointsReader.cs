using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStructuredPointsReader : vtkDataReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredPointsReader";

		public new static readonly string MRClassNameKey;

		static vtkStructuredPointsReader()
		{
			vtkStructuredPointsReader.MRClassNameKey = "class vtkStructuredPointsReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredPointsReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredPointsReader"));
		}

		public vtkStructuredPointsReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredPointsReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredPointsReader New()
		{
			vtkStructuredPointsReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredPointsReader.vtkStructuredPointsReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredPointsReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkStructuredPointsReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkStructuredPointsReader.vtkStructuredPointsReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredPointsReader_GetOutput_01(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkStructuredPoints GetOutput(int idx)
		{
			vtkStructuredPoints vtkStructuredPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredPointsReader.vtkStructuredPointsReader_GetOutput_01(base.GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPoints = (vtkStructuredPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPoints.Register(null);
				}
			}
			return vtkStructuredPoints;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredPointsReader_GetOutput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkStructuredPoints GetOutput()
		{
			vtkStructuredPoints vtkStructuredPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredPointsReader.vtkStructuredPointsReader_GetOutput_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPoints = (vtkStructuredPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPoints.Register(null);
				}
			}
			return vtkStructuredPoints;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkStructuredPointsReader_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStructuredPointsReader.vtkStructuredPointsReader_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkStructuredPointsReader_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStructuredPointsReader.vtkStructuredPointsReader_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredPointsReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStructuredPointsReader NewInstance()
		{
			vtkStructuredPointsReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredPointsReader.vtkStructuredPointsReader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredPointsReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkStructuredPointsReader_ReadMetaData_07(HandleRef pThis, HandleRef outInfo);

		public override int ReadMetaData(vtkInformation outInfo)
		{
			return vtkStructuredPointsReader.vtkStructuredPointsReader_ReadMetaData_07(base.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredPointsReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredPointsReader SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredPointsReader vtkStructuredPointsReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredPointsReader.vtkStructuredPointsReader_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPointsReader = (vtkStructuredPointsReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPointsReader.Register(null);
				}
			}
			return vtkStructuredPointsReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkStructuredPointsReader_SetOutput_09(HandleRef pThis, HandleRef output);

		public void SetOutput(vtkStructuredPoints output)
		{
			vtkStructuredPointsReader.vtkStructuredPointsReader_SetOutput_09(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}
	}
}
