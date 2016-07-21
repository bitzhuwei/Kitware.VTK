using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRIBProperty : vtkProperty
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRIBProperty";

		public new static readonly string MRClassNameKey;

		static vtkRIBProperty()
		{
			vtkRIBProperty.MRClassNameKey = "class vtkRIBProperty";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRIBProperty.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRIBProperty"));
		}

		public vtkRIBProperty(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkRIBProperty_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRIBProperty New()
		{
			vtkRIBProperty result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRIBProperty.vtkRIBProperty_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRIBProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRIBProperty() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRIBProperty.vtkRIBProperty_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkRIBProperty_AddParameter_01(HandleRef pThis, string parameter, string value);

		public void AddParameter(string parameter, string value)
		{
			vtkRIBProperty.vtkRIBProperty_AddParameter_01(base.GetCppThis(), parameter, value);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkRIBProperty_AddVariable_02(HandleRef pThis, string variable, string declaration);

		public void AddVariable(string variable, string declaration)
		{
			vtkRIBProperty.vtkRIBProperty_AddVariable_02(base.GetCppThis(), variable, declaration);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkRIBProperty_GetDeclarations_03(HandleRef pThis);

		public string GetDeclarations()
		{
			return Marshal.PtrToStringAnsi(vtkRIBProperty.vtkRIBProperty_GetDeclarations_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkRIBProperty_GetDisplacementShader_04(HandleRef pThis);

		public virtual string GetDisplacementShader()
		{
			return Marshal.PtrToStringAnsi(vtkRIBProperty.vtkRIBProperty_GetDisplacementShader_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkRIBProperty_GetParameters_05(HandleRef pThis);

		public string GetParameters()
		{
			return Marshal.PtrToStringAnsi(vtkRIBProperty.vtkRIBProperty_GetParameters_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkRIBProperty_GetSurfaceShader_06(HandleRef pThis);

		public virtual string GetSurfaceShader()
		{
			return Marshal.PtrToStringAnsi(vtkRIBProperty.vtkRIBProperty_GetSurfaceShader_06(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkRIBProperty_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRIBProperty.vtkRIBProperty_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkRIBProperty_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRIBProperty.vtkRIBProperty_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkRIBProperty_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRIBProperty NewInstance()
		{
			vtkRIBProperty result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRIBProperty.vtkRIBProperty_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRIBProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkRIBProperty_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRIBProperty SafeDownCast(vtkObjectBase o)
		{
			vtkRIBProperty vtkRIBProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRIBProperty.vtkRIBProperty_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRIBProperty = (vtkRIBProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRIBProperty.Register(null);
				}
			}
			return vtkRIBProperty;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkRIBProperty_SetDisplacementShader_12(HandleRef pThis, string _arg);

		public virtual void SetDisplacementShader(string _arg)
		{
			vtkRIBProperty.vtkRIBProperty_SetDisplacementShader_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkRIBProperty_SetParameter_13(HandleRef pThis, string parameter, string value);

		public void SetParameter(string parameter, string value)
		{
			vtkRIBProperty.vtkRIBProperty_SetParameter_13(base.GetCppThis(), parameter, value);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkRIBProperty_SetSurfaceShader_14(HandleRef pThis, string _arg);

		public virtual void SetSurfaceShader(string _arg)
		{
			vtkRIBProperty.vtkRIBProperty_SetSurfaceShader_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkRIBProperty_SetVariable_15(HandleRef pThis, string variable, string declaration);

		public void SetVariable(string variable, string declaration)
		{
			vtkRIBProperty.vtkRIBProperty_SetVariable_15(base.GetCppThis(), variable, declaration);
		}
	}
}
