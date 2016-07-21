using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMNITransformReader : vtkAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMNITransformReader";

		public new static readonly string MRClassNameKey;

		static vtkMNITransformReader()
		{
			vtkMNITransformReader.MRClassNameKey = "class vtkMNITransformReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMNITransformReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMNITransformReader"));
		}

		public vtkMNITransformReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITransformReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMNITransformReader New()
		{
			vtkMNITransformReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMNITransformReader.vtkMNITransformReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMNITransformReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMNITransformReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMNITransformReader.vtkMNITransformReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkMNITransformReader_CanReadFile_01(HandleRef pThis, string name);

		public virtual int CanReadFile(string name)
		{
			return vtkMNITransformReader.vtkMNITransformReader_CanReadFile_01(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITransformReader_GetComments_02(HandleRef pThis);

		public virtual string GetComments()
		{
			return Marshal.PtrToStringAnsi(vtkMNITransformReader.vtkMNITransformReader_GetComments_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITransformReader_GetDescriptiveName_03(HandleRef pThis);

		public virtual string GetDescriptiveName()
		{
			return Marshal.PtrToStringAnsi(vtkMNITransformReader.vtkMNITransformReader_GetDescriptiveName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITransformReader_GetFileExtensions_04(HandleRef pThis);

		public virtual string GetFileExtensions()
		{
			return Marshal.PtrToStringAnsi(vtkMNITransformReader.vtkMNITransformReader_GetFileExtensions_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITransformReader_GetFileName_05(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkMNITransformReader.vtkMNITransformReader_GetFileName_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITransformReader_GetNthTransform_06(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractTransform GetNthTransform(int i)
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMNITransformReader.vtkMNITransformReader_GetNthTransform_06(base.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkMNITransformReader_GetNumberOfTransforms_07(HandleRef pThis);

		public virtual int GetNumberOfTransforms()
		{
			return vtkMNITransformReader.vtkMNITransformReader_GetNumberOfTransforms_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITransformReader_GetTransform_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractTransform GetTransform()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMNITransformReader.vtkMNITransformReader_GetTransform_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkMNITransformReader_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMNITransformReader.vtkMNITransformReader_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkMNITransformReader_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMNITransformReader.vtkMNITransformReader_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITransformReader_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMNITransformReader NewInstance()
		{
			vtkMNITransformReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMNITransformReader.vtkMNITransformReader_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMNITransformReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNITransformReader_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMNITransformReader SafeDownCast(vtkObjectBase o)
		{
			vtkMNITransformReader vtkMNITransformReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMNITransformReader.vtkMNITransformReader_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMNITransformReader = (vtkMNITransformReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMNITransformReader.Register(null);
				}
			}
			return vtkMNITransformReader;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkMNITransformReader_SetFileName_14(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkMNITransformReader.vtkMNITransformReader_SetFileName_14(base.GetCppThis(), _arg);
		}
	}
}
