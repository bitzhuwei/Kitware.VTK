using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGenericVertexAttributeMapping : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericVertexAttributeMapping";

		public new static readonly string MRClassNameKey;

		static vtkGenericVertexAttributeMapping()
		{
			vtkGenericVertexAttributeMapping.MRClassNameKey = "class vtkGenericVertexAttributeMapping";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericVertexAttributeMapping.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericVertexAttributeMapping"));
		}

		public vtkGenericVertexAttributeMapping(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericVertexAttributeMapping_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericVertexAttributeMapping New()
		{
			vtkGenericVertexAttributeMapping result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericVertexAttributeMapping)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGenericVertexAttributeMapping() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericVertexAttributeMapping_AddMapping_01(HandleRef pThis, string attributeName, string arrayName, int fieldAssociation, int component);

		public void AddMapping(string attributeName, string arrayName, int fieldAssociation, int component)
		{
			vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_AddMapping_01(base.GetCppThis(), attributeName, arrayName, fieldAssociation, component);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericVertexAttributeMapping_AddMapping_02(HandleRef pThis, int unit, string arrayName, int fieldAssociation, int component);

		public void AddMapping(int unit, string arrayName, int fieldAssociation, int component)
		{
			vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_AddMapping_02(base.GetCppThis(), unit, arrayName, fieldAssociation, component);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericVertexAttributeMapping_GetArrayName_03(HandleRef pThis, uint index);

		public string GetArrayName(uint index)
		{
			return Marshal.PtrToStringAnsi(vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_GetArrayName_03(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericVertexAttributeMapping_GetAttributeName_04(HandleRef pThis, uint index);

		public string GetAttributeName(uint index)
		{
			return Marshal.PtrToStringAnsi(vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_GetAttributeName_04(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGenericVertexAttributeMapping_GetComponent_05(HandleRef pThis, uint index);

		public int GetComponent(uint index)
		{
			return vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_GetComponent_05(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGenericVertexAttributeMapping_GetFieldAssociation_06(HandleRef pThis, uint index);

		public int GetFieldAssociation(uint index)
		{
			return vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_GetFieldAssociation_06(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkGenericVertexAttributeMapping_GetNumberOfMappings_07(HandleRef pThis);

		public uint GetNumberOfMappings()
		{
			return vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_GetNumberOfMappings_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGenericVertexAttributeMapping_GetTextureUnit_08(HandleRef pThis, uint index);

		public int GetTextureUnit(uint index)
		{
			return vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_GetTextureUnit_08(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGenericVertexAttributeMapping_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGenericVertexAttributeMapping_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericVertexAttributeMapping_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGenericVertexAttributeMapping NewInstance()
		{
			vtkGenericVertexAttributeMapping result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericVertexAttributeMapping)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGenericVertexAttributeMapping_RemoveAllMappings_13(HandleRef pThis);

		public void RemoveAllMappings()
		{
			vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_RemoveAllMappings_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkGenericVertexAttributeMapping_RemoveMapping_14(HandleRef pThis, string attributeName);

		public bool RemoveMapping(string attributeName)
		{
			return vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_RemoveMapping_14(base.GetCppThis(), attributeName) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericVertexAttributeMapping_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericVertexAttributeMapping SafeDownCast(vtkObjectBase o)
		{
			vtkGenericVertexAttributeMapping vtkGenericVertexAttributeMapping = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericVertexAttributeMapping = (vtkGenericVertexAttributeMapping)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericVertexAttributeMapping.Register(null);
				}
			}
			return vtkGenericVertexAttributeMapping;
		}
	}
}
