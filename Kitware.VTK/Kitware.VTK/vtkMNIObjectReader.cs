using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMNIObjectReader : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMNIObjectReader";

		public new static readonly string MRClassNameKey;

		static vtkMNIObjectReader()
		{
			vtkMNIObjectReader.MRClassNameKey = "class vtkMNIObjectReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMNIObjectReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMNIObjectReader"));
		}

		public vtkMNIObjectReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNIObjectReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMNIObjectReader New()
		{
			vtkMNIObjectReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMNIObjectReader.vtkMNIObjectReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMNIObjectReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMNIObjectReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMNIObjectReader.vtkMNIObjectReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkMNIObjectReader_CanReadFile_01(HandleRef pThis, string name);

		public virtual int CanReadFile(string name)
		{
			return vtkMNIObjectReader.vtkMNIObjectReader_CanReadFile_01(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNIObjectReader_GetDescriptiveName_02(HandleRef pThis);

		public virtual string GetDescriptiveName()
		{
			return Marshal.PtrToStringAnsi(vtkMNIObjectReader.vtkMNIObjectReader_GetDescriptiveName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNIObjectReader_GetFileExtensions_03(HandleRef pThis);

		public virtual string GetFileExtensions()
		{
			return Marshal.PtrToStringAnsi(vtkMNIObjectReader.vtkMNIObjectReader_GetFileExtensions_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNIObjectReader_GetFileName_04(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkMNIObjectReader.vtkMNIObjectReader_GetFileName_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNIObjectReader_GetProperty_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMNIObjectReader.vtkMNIObjectReader_GetProperty_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkMNIObjectReader_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMNIObjectReader.vtkMNIObjectReader_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkMNIObjectReader_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMNIObjectReader.vtkMNIObjectReader_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNIObjectReader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMNIObjectReader NewInstance()
		{
			vtkMNIObjectReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMNIObjectReader.vtkMNIObjectReader_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMNIObjectReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkMNIObjectReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMNIObjectReader SafeDownCast(vtkObjectBase o)
		{
			vtkMNIObjectReader vtkMNIObjectReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMNIObjectReader.vtkMNIObjectReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMNIObjectReader = (vtkMNIObjectReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMNIObjectReader.Register(null);
				}
			}
			return vtkMNIObjectReader;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkMNIObjectReader_SetFileName_11(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkMNIObjectReader.vtkMNIObjectReader_SetFileName_11(base.GetCppThis(), _arg);
		}
	}
}
