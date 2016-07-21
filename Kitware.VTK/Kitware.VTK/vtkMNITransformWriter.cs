using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMNITransformWriter : vtkAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMNITransformWriter";

		public new static readonly string MRClassNameKey;

		static vtkMNITransformWriter()
		{
			vtkMNITransformWriter.MRClassNameKey = "class vtkMNITransformWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMNITransformWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMNITransformWriter"));
		}

		public vtkMNITransformWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITransformWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMNITransformWriter New()
		{
			vtkMNITransformWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMNITransformWriter.vtkMNITransformWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMNITransformWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMNITransformWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMNITransformWriter.vtkMNITransformWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkMNITransformWriter_AddTransform_01(HandleRef pThis, HandleRef transform);

		public virtual void AddTransform(vtkAbstractTransform transform)
		{
			vtkMNITransformWriter.vtkMNITransformWriter_AddTransform_01(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITransformWriter_GetComments_02(HandleRef pThis);

		public virtual string GetComments()
		{
			return Marshal.PtrToStringAnsi(vtkMNITransformWriter.vtkMNITransformWriter_GetComments_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITransformWriter_GetDescriptiveName_03(HandleRef pThis);

		public virtual string GetDescriptiveName()
		{
			return Marshal.PtrToStringAnsi(vtkMNITransformWriter.vtkMNITransformWriter_GetDescriptiveName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITransformWriter_GetFileExtensions_04(HandleRef pThis);

		public virtual string GetFileExtensions()
		{
			return Marshal.PtrToStringAnsi(vtkMNITransformWriter.vtkMNITransformWriter_GetFileExtensions_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITransformWriter_GetFileName_05(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkMNITransformWriter.vtkMNITransformWriter_GetFileName_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkMNITransformWriter_GetNumberOfTransforms_06(HandleRef pThis);

		public virtual int GetNumberOfTransforms()
		{
			return vtkMNITransformWriter.vtkMNITransformWriter_GetNumberOfTransforms_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITransformWriter_GetTransform_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractTransform GetTransform()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMNITransformWriter.vtkMNITransformWriter_GetTransform_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkMNITransformWriter_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMNITransformWriter.vtkMNITransformWriter_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkMNITransformWriter_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMNITransformWriter.vtkMNITransformWriter_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITransformWriter_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMNITransformWriter NewInstance()
		{
			vtkMNITransformWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMNITransformWriter.vtkMNITransformWriter_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMNITransformWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITransformWriter_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMNITransformWriter SafeDownCast(vtkObjectBase o)
		{
			vtkMNITransformWriter vtkMNITransformWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMNITransformWriter.vtkMNITransformWriter_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMNITransformWriter = (vtkMNITransformWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMNITransformWriter.Register(null);
				}
			}
			return vtkMNITransformWriter;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkMNITransformWriter_SetComments_13(HandleRef pThis, string _arg);

		public virtual void SetComments(string _arg)
		{
			vtkMNITransformWriter.vtkMNITransformWriter_SetComments_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkMNITransformWriter_SetFileName_14(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkMNITransformWriter.vtkMNITransformWriter_SetFileName_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkMNITransformWriter_SetTransform_15(HandleRef pThis, HandleRef transform);

		public virtual void SetTransform(vtkAbstractTransform transform)
		{
			vtkMNITransformWriter.vtkMNITransformWriter_SetTransform_15(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkMNITransformWriter_Write_16(HandleRef pThis);

		public virtual void Write()
		{
			vtkMNITransformWriter.vtkMNITransformWriter_Write_16(base.GetCppThis());
		}
	}
}
