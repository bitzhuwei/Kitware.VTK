using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeoImageNode : vtkGeoTreeNode
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoImageNode";

		public new static readonly string MRClassNameKey;

		static vtkGeoImageNode()
		{
			vtkGeoImageNode.MRClassNameKey = "class vtkGeoImageNode";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoImageNode.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoImageNode"));
		}

		public vtkGeoImageNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoImageNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoImageNode New()
		{
			vtkGeoImageNode result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoImageNode.vtkGeoImageNode_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoImageNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeoImageNode() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeoImageNode.vtkGeoImageNode_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoImageNode_CropImageForTile_01(HandleRef pThis, HandleRef image, IntPtr imageLonLatExt, string prefix);

		public void CropImageForTile(vtkImageData image, IntPtr imageLonLatExt, string prefix)
		{
			vtkGeoImageNode.vtkGeoImageNode_CropImageForTile_01(base.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis(), imageLonLatExt, prefix);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoImageNode_DeepCopy_02(HandleRef pThis, HandleRef src);

		public override void DeepCopy(vtkGeoTreeNode src)
		{
			vtkGeoImageNode.vtkGeoImageNode_DeepCopy_02(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoImageNode_DeleteData_03(HandleRef pThis);

		public override void DeleteData()
		{
			vtkGeoImageNode.vtkGeoImageNode_DeleteData_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoImageNode_GetChild_04(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkGeoImageNode GetChild(int idx)
		{
			vtkGeoImageNode vtkGeoImageNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoImageNode.vtkGeoImageNode_GetChild_04(base.GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoImageNode = (vtkGeoImageNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoImageNode.Register(null);
				}
			}
			return vtkGeoImageNode;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoImageNode_GetImage_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetImage()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoImageNode.vtkGeoImageNode_GetImage_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoImageNode_GetParent_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkGeoImageNode GetParent()
		{
			vtkGeoImageNode vtkGeoImageNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoImageNode.vtkGeoImageNode_GetParent_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoImageNode = (vtkGeoImageNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoImageNode.Register(null);
				}
			}
			return vtkGeoImageNode;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoImageNode_GetTexture_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkTexture GetTexture()
		{
			vtkTexture vtkTexture = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoImageNode.vtkGeoImageNode_GetTexture_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexture = (vtkTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexture.Register(null);
				}
			}
			return vtkTexture;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern byte vtkGeoImageNode_HasData_08(HandleRef pThis);

		public override bool HasData()
		{
			return vtkGeoImageNode.vtkGeoImageNode_HasData_08(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoImageNode_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoImageNode.vtkGeoImageNode_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoImageNode_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoImageNode.vtkGeoImageNode_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoImageNode_LoadAnImage_11(HandleRef pThis, string prefix);

		public void LoadAnImage(string prefix)
		{
			vtkGeoImageNode.vtkGeoImageNode_LoadAnImage_11(base.GetCppThis(), prefix);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoImageNode_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoImageNode NewInstance()
		{
			vtkGeoImageNode result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoImageNode.vtkGeoImageNode_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoImageNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoImageNode_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoImageNode SafeDownCast(vtkObjectBase o)
		{
			vtkGeoImageNode vtkGeoImageNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoImageNode.vtkGeoImageNode_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoImageNode = (vtkGeoImageNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoImageNode.Register(null);
				}
			}
			return vtkGeoImageNode;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoImageNode_SetImage_15(HandleRef pThis, HandleRef image);

		public void SetImage(vtkImageData image)
		{
			vtkGeoImageNode.vtkGeoImageNode_SetImage_15(base.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoImageNode_SetTexture_16(HandleRef pThis, HandleRef texture);

		public void SetTexture(vtkTexture texture)
		{
			vtkGeoImageNode.vtkGeoImageNode_SetTexture_16(base.GetCppThis(), (texture == null) ? default(HandleRef) : texture.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoImageNode_ShallowCopy_17(HandleRef pThis, HandleRef src);

		public override void ShallowCopy(vtkGeoTreeNode src)
		{
			vtkGeoImageNode.vtkGeoImageNode_ShallowCopy_17(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}
	}
}
