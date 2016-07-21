using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMedicalImageReader2 : vtkImageReader2
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMedicalImageReader2";

		public new static readonly string MRClassNameKey;

		static vtkMedicalImageReader2()
		{
			vtkMedicalImageReader2.MRClassNameKey = "class vtkMedicalImageReader2";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMedicalImageReader2.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMedicalImageReader2"));
		}

		public vtkMedicalImageReader2(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageReader2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMedicalImageReader2 New()
		{
			vtkMedicalImageReader2 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMedicalImageReader2.vtkMedicalImageReader2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMedicalImageReader2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMedicalImageReader2() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMedicalImageReader2.vtkMedicalImageReader2_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageReader2_GetDate_01(HandleRef pThis);

		public virtual string GetDate()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageReader2.vtkMedicalImageReader2_GetDate_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageReader2_GetImageNumber_02(HandleRef pThis);

		public virtual string GetImageNumber()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageReader2.vtkMedicalImageReader2_GetImageNumber_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageReader2_GetMedicalImageProperties_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMedicalImageProperties GetMedicalImageProperties()
		{
			vtkMedicalImageProperties vtkMedicalImageProperties = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMedicalImageReader2.vtkMedicalImageReader2_GetMedicalImageProperties_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMedicalImageProperties = (vtkMedicalImageProperties)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMedicalImageProperties.Register(null);
				}
			}
			return vtkMedicalImageProperties;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageReader2_GetModality_04(HandleRef pThis);

		public virtual string GetModality()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageReader2.vtkMedicalImageReader2_GetModality_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageReader2_GetPatientID_05(HandleRef pThis);

		public virtual string GetPatientID()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageReader2.vtkMedicalImageReader2_GetPatientID_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageReader2_GetPatientName_06(HandleRef pThis);

		public virtual string GetPatientName()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageReader2.vtkMedicalImageReader2_GetPatientName_06(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageReader2_GetSeries_07(HandleRef pThis);

		public virtual string GetSeries()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageReader2.vtkMedicalImageReader2_GetSeries_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageReader2_GetStudy_08(HandleRef pThis);

		public virtual string GetStudy()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageReader2.vtkMedicalImageReader2_GetStudy_08(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageReader2_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMedicalImageReader2.vtkMedicalImageReader2_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageReader2_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMedicalImageReader2.vtkMedicalImageReader2_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageReader2_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMedicalImageReader2 NewInstance()
		{
			vtkMedicalImageReader2 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMedicalImageReader2.vtkMedicalImageReader2_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMedicalImageReader2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageReader2_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMedicalImageReader2 SafeDownCast(vtkObjectBase o)
		{
			vtkMedicalImageReader2 vtkMedicalImageReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMedicalImageReader2.vtkMedicalImageReader2_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMedicalImageReader = (vtkMedicalImageReader2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMedicalImageReader.Register(null);
				}
			}
			return vtkMedicalImageReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageReader2_SetDate_14(HandleRef pThis, string arg0);

		public virtual void SetDate(string arg0)
		{
			vtkMedicalImageReader2.vtkMedicalImageReader2_SetDate_14(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageReader2_SetImageNumber_15(HandleRef pThis, string arg0);

		public virtual void SetImageNumber(string arg0)
		{
			vtkMedicalImageReader2.vtkMedicalImageReader2_SetImageNumber_15(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageReader2_SetModality_16(HandleRef pThis, string arg0);

		public virtual void SetModality(string arg0)
		{
			vtkMedicalImageReader2.vtkMedicalImageReader2_SetModality_16(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageReader2_SetPatientID_17(HandleRef pThis, string arg0);

		public virtual void SetPatientID(string arg0)
		{
			vtkMedicalImageReader2.vtkMedicalImageReader2_SetPatientID_17(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageReader2_SetPatientName_18(HandleRef pThis, string arg0);

		public virtual void SetPatientName(string arg0)
		{
			vtkMedicalImageReader2.vtkMedicalImageReader2_SetPatientName_18(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageReader2_SetSeries_19(HandleRef pThis, string arg0);

		public virtual void SetSeries(string arg0)
		{
			vtkMedicalImageReader2.vtkMedicalImageReader2_SetSeries_19(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageReader2_SetStudy_20(HandleRef pThis, string arg0);

		public virtual void SetStudy(string arg0)
		{
			vtkMedicalImageReader2.vtkMedicalImageReader2_SetStudy_20(base.GetCppThis(), arg0);
		}
	}
}
