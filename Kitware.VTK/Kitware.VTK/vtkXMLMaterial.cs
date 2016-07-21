using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkXMLMaterial : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLMaterial";

		public new static readonly string MRClassNameKey;

		static vtkXMLMaterial()
		{
			vtkXMLMaterial.MRClassNameKey = "class vtkXMLMaterial";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLMaterial.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLMaterial"));
		}

		public vtkXMLMaterial(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLMaterial_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLMaterial New()
		{
			vtkXMLMaterial result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLMaterial.vtkXMLMaterial_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLMaterial)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkXMLMaterial() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkXMLMaterial.vtkXMLMaterial_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLMaterial_CreateInstance_01(string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkXMLMaterial CreateInstance(string name)
		{
			vtkXMLMaterial result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLMaterial.vtkXMLMaterial_CreateInstance_01(name, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLMaterial)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLMaterial_GetFragmentShader_02(HandleRef pThis, int id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkXMLShader GetFragmentShader(int id)
		{
			vtkXMLShader vtkXMLShader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLMaterial.vtkXMLMaterial_GetFragmentShader_02(base.GetCppThis(), id, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLShader = (vtkXMLShader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLShader.Register(null);
				}
			}
			return vtkXMLShader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLMaterial_GetNumberOfFragmentShaders_03(HandleRef pThis);

		public int GetNumberOfFragmentShaders()
		{
			return vtkXMLMaterial.vtkXMLMaterial_GetNumberOfFragmentShaders_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLMaterial_GetNumberOfProperties_04(HandleRef pThis);

		public int GetNumberOfProperties()
		{
			return vtkXMLMaterial.vtkXMLMaterial_GetNumberOfProperties_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLMaterial_GetNumberOfTextures_05(HandleRef pThis);

		public int GetNumberOfTextures()
		{
			return vtkXMLMaterial.vtkXMLMaterial_GetNumberOfTextures_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLMaterial_GetNumberOfVertexShaders_06(HandleRef pThis);

		public int GetNumberOfVertexShaders()
		{
			return vtkXMLMaterial.vtkXMLMaterial_GetNumberOfVertexShaders_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLMaterial_GetProperty_07(HandleRef pThis, int id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkXMLDataElement GetProperty(int id)
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLMaterial.vtkXMLMaterial_GetProperty_07(base.GetCppThis(), id, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLMaterial_GetRootElement_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkXMLDataElement GetRootElement()
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLMaterial.vtkXMLMaterial_GetRootElement_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLMaterial_GetShaderLanguage_09(HandleRef pThis);

		public int GetShaderLanguage()
		{
			return vtkXMLMaterial.vtkXMLMaterial_GetShaderLanguage_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLMaterial_GetShaderStyle_10(HandleRef pThis);

		public int GetShaderStyle()
		{
			return vtkXMLMaterial.vtkXMLMaterial_GetShaderStyle_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLMaterial_GetTexture_11(HandleRef pThis, int id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkXMLDataElement GetTexture(int id)
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLMaterial.vtkXMLMaterial_GetTexture_11(base.GetCppThis(), id, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLMaterial_GetVertexShader_12(HandleRef pThis, int id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkXMLShader GetVertexShader(int id)
		{
			vtkXMLShader vtkXMLShader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLMaterial.vtkXMLMaterial_GetVertexShader_12(base.GetCppThis(), id, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLShader = (vtkXMLShader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLShader.Register(null);
				}
			}
			return vtkXMLShader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLMaterial_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLMaterial.vtkXMLMaterial_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLMaterial_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLMaterial.vtkXMLMaterial_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLMaterial_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLMaterial NewInstance()
		{
			vtkXMLMaterial result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLMaterial.vtkXMLMaterial_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLMaterial)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLMaterial_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLMaterial SafeDownCast(vtkObjectBase o)
		{
			vtkXMLMaterial vtkXMLMaterial = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLMaterial.vtkXMLMaterial_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLMaterial = (vtkXMLMaterial)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLMaterial.Register(null);
				}
			}
			return vtkXMLMaterial;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLMaterial_SetRootElement_18(HandleRef pThis, HandleRef arg0);

		public void SetRootElement(vtkXMLDataElement arg0)
		{
			vtkXMLMaterial.vtkXMLMaterial_SetRootElement_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
