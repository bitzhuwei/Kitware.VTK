using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMINCImageWriter : vtkImageWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMINCImageWriter";

		public new static readonly string MRClassNameKey;

		static vtkMINCImageWriter()
		{
			vtkMINCImageWriter.MRClassNameKey = "class vtkMINCImageWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMINCImageWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMINCImageWriter"));
		}

		public vtkMINCImageWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMINCImageWriter New()
		{
			vtkMINCImageWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMINCImageWriter.vtkMINCImageWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMINCImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMINCImageWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMINCImageWriter.vtkMINCImageWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageWriter_GetDescriptiveName_01(HandleRef pThis);

		public virtual string GetDescriptiveName()
		{
			return Marshal.PtrToStringAnsi(vtkMINCImageWriter.vtkMINCImageWriter_GetDescriptiveName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageWriter_GetDirectionCosines_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMatrix4x4 GetDirectionCosines()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMINCImageWriter.vtkMINCImageWriter_GetDirectionCosines_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageWriter_GetFileExtensions_03(HandleRef pThis);

		public virtual string GetFileExtensions()
		{
			return Marshal.PtrToStringAnsi(vtkMINCImageWriter.vtkMINCImageWriter_GetFileExtensions_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageWriter_GetHistoryAddition_04(HandleRef pThis);

		public virtual string GetHistoryAddition()
		{
			return Marshal.PtrToStringAnsi(vtkMINCImageWriter.vtkMINCImageWriter_GetHistoryAddition_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageWriter_GetImageAttributes_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMINCImageAttributes GetImageAttributes()
		{
			vtkMINCImageAttributes vtkMINCImageAttributes = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMINCImageWriter.vtkMINCImageWriter_GetImageAttributes_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMINCImageAttributes = (vtkMINCImageAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMINCImageAttributes.Register(null);
				}
			}
			return vtkMINCImageAttributes;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkMINCImageWriter_GetRescaleIntercept_06(HandleRef pThis);

		public virtual double GetRescaleIntercept()
		{
			return vtkMINCImageWriter.vtkMINCImageWriter_GetRescaleIntercept_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkMINCImageWriter_GetRescaleSlope_07(HandleRef pThis);

		public virtual double GetRescaleSlope()
		{
			return vtkMINCImageWriter.vtkMINCImageWriter_GetRescaleSlope_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMINCImageWriter_GetStrictValidation_08(HandleRef pThis);

		public virtual int GetStrictValidation()
		{
			return vtkMINCImageWriter.vtkMINCImageWriter_GetStrictValidation_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMINCImageWriter_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMINCImageWriter.vtkMINCImageWriter_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMINCImageWriter_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMINCImageWriter.vtkMINCImageWriter_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageWriter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMINCImageWriter NewInstance()
		{
			vtkMINCImageWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMINCImageWriter.vtkMINCImageWriter_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMINCImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageWriter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMINCImageWriter SafeDownCast(vtkObjectBase o)
		{
			vtkMINCImageWriter vtkMINCImageWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMINCImageWriter.vtkMINCImageWriter_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMINCImageWriter = (vtkMINCImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMINCImageWriter.Register(null);
				}
			}
			return vtkMINCImageWriter;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageWriter_SetDirectionCosines_14(HandleRef pThis, HandleRef matrix);

		public virtual void SetDirectionCosines(vtkMatrix4x4 matrix)
		{
			vtkMINCImageWriter.vtkMINCImageWriter_SetDirectionCosines_14(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageWriter_SetFileName_15(HandleRef pThis, string name);

		public override void SetFileName(string name)
		{
			vtkMINCImageWriter.vtkMINCImageWriter_SetFileName_15(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageWriter_SetHistoryAddition_16(HandleRef pThis, string _arg);

		public virtual void SetHistoryAddition(string _arg)
		{
			vtkMINCImageWriter.vtkMINCImageWriter_SetHistoryAddition_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageWriter_SetImageAttributes_17(HandleRef pThis, HandleRef attributes);

		public virtual void SetImageAttributes(vtkMINCImageAttributes attributes)
		{
			vtkMINCImageWriter.vtkMINCImageWriter_SetImageAttributes_17(base.GetCppThis(), (attributes == null) ? default(HandleRef) : attributes.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageWriter_SetRescaleIntercept_18(HandleRef pThis, double _arg);

		public virtual void SetRescaleIntercept(double _arg)
		{
			vtkMINCImageWriter.vtkMINCImageWriter_SetRescaleIntercept_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageWriter_SetRescaleSlope_19(HandleRef pThis, double _arg);

		public virtual void SetRescaleSlope(double _arg)
		{
			vtkMINCImageWriter.vtkMINCImageWriter_SetRescaleSlope_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageWriter_SetStrictValidation_20(HandleRef pThis, int _arg);

		public virtual void SetStrictValidation(int _arg)
		{
			vtkMINCImageWriter.vtkMINCImageWriter_SetStrictValidation_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageWriter_StrictValidationOff_21(HandleRef pThis);

		public virtual void StrictValidationOff()
		{
			vtkMINCImageWriter.vtkMINCImageWriter_StrictValidationOff_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageWriter_StrictValidationOn_22(HandleRef pThis);

		public virtual void StrictValidationOn()
		{
			vtkMINCImageWriter.vtkMINCImageWriter_StrictValidationOn_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageWriter_Write_23(HandleRef pThis);

		public override void Write()
		{
			vtkMINCImageWriter.vtkMINCImageWriter_Write_23(base.GetCppThis());
		}
	}
}
